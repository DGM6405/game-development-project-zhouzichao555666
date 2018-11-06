using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectBox : MonoBehaviour {

    static Texture2D _whiteTexture;

    static bool isSelecting = false;
   static  Vector3 mousePosition1;


    static float Zmin = 0;
    static float Zmax = 0;



    Camera cam;
    // Use this for initialization
    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButtonDown(0))
        {
            isSelecting = true;

		
            mousePosition1 = Input.mousePosition;

            
        }
        // If we let go of the left mouse button, end selection
       

    }
    private void LateUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            isSelecting = false;



        }
    }

    public static Texture2D WhiteTexture
    {
        get
        {
            if (_whiteTexture == null)
            {
                _whiteTexture = new Texture2D(1, 1);
                _whiteTexture.SetPixel(0, 0, Color.white);
                _whiteTexture.Apply();
            }

            return _whiteTexture;
        }
    }

    public static void DrawScreenRect(Rect rect, Color color)
    {
        GUI.color = color;
        GUI.DrawTexture(rect, WhiteTexture);
        GUI.color = Color.white;
    }

    
    public static void DrawScreenRectBorder(Rect rect, float thickness, Color color)
    {
        // Top
        DrawScreenRect(new Rect(rect.xMin, rect.yMin, rect.width, thickness), color);
        // Left
        DrawScreenRect(new Rect(rect.xMin, rect.yMin, thickness, rect.height), color);
        // Right
        DrawScreenRect(new Rect(rect.xMax - thickness, rect.yMin, thickness, rect.height), color);
        // Bottom
        DrawScreenRect(new Rect(rect.xMin, rect.yMax - thickness, rect.width, thickness), color);
    }

    

    void OnGUI()
    {
        if (isSelecting)
        {
            // Create a rect from both mouse positions
            var rect = GetScreenRect(mousePosition1, Input.mousePosition);
            DrawScreenRect(rect, new Color(0.8f, 0.8f, 0.95f, 0.25f));
            DrawScreenRectBorder(rect, 2, new Color(0.8f, 0.8f, 0.95f));
        }
    }

    public static Rect GetScreenRect(Vector3 screenPosition1, Vector3 screenPosition2)
    {
        // Move origin from bottom left to top left
        screenPosition1.y = Screen.height - screenPosition1.y;
        screenPosition2.y = Screen.height - screenPosition2.y;
        // Calculate corners
        var topLeft = Vector3.Min(screenPosition1, screenPosition2);
        var bottomRight = Vector3.Max(screenPosition1, screenPosition2);
        // Create Rect
        return Rect.MinMaxRect(topLeft.x, topLeft.y, bottomRight.x, bottomRight.y);
    }

public static Bounds GetViewportBounds(Camera camera, Vector3 screenPosition1, Vector3 screenPosition2)
    {
        var v1 = Camera.main.ScreenToViewportPoint(screenPosition1);
        var v2 = Camera.main.ScreenToViewportPoint(screenPosition2);
        var min = Vector3.Min(v1, v2);
        var max = Vector3.Max(v1, v2);
        min.z = 25.0f;
        max.z = 27.0f;

        var bounds = new Bounds();
        bounds.SetMinMax(min, max);
        return bounds;
    }


    public static bool IsWithinSelectionBounds(GameObject gameObject)
    {
        


		if (!isSelecting) {


			print ("2");
			return false;
		}







        var camera = Camera.main;
        var viewportBounds =
            GetViewportBounds(camera, mousePosition1, Input.mousePosition);

        Debug.Log(
            camera.WorldToViewportPoint(gameObject.transform.position));
        Debug.Log(
            viewportBounds);



        return viewportBounds.Contains(
            camera.WorldToViewportPoint(gameObject.transform.position));




        
    }


    private Vector3 getSelectZmin()
    {

        Vector2 screenPosition = Input.mousePosition;
      Ray ray = cam.ScreenPointToRay(screenPosition);
      RaycastHit hitPosition;      
       Physics.Raycast(cam.transform.position, ray.direction, out hitPosition, 1000);
     Debug.DrawLine(cam.transform.position, hitPosition.point, Color.red);
       return hitPosition.point;

     }
    private Vector3 getSelectZmax()
    {

        Vector2 screenPosition = Input.mousePosition;
        Ray ray = cam.ScreenPointToRay(screenPosition);
        RaycastHit hitPosition;
        Physics.Raycast(cam.transform.position, ray.direction, out hitPosition, 1000);
        Debug.DrawLine(cam.transform.position, hitPosition.point, Color.red);
        return hitPosition.point;

    }



}
