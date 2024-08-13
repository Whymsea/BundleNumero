using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed = 0.5f;
    public float panSpeed = 0.1f;
    public float minZoom = 1f;
    public float maxZoom = 10f;

    private Vector2? lastTouchPosition;
    private float initialOrthoSize;

    void Start()
    {
        initialOrthoSize = Camera.main.orthographicSize;
    }

    void Update()
    {
        // Gestion du zoom
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            float zoomChange = deltaMagnitudeDiff * zoomSpeed * Time.deltaTime;
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize + zoomChange, minZoom, maxZoom);
        }

        // Gestion du défilement
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 deltaPosition = touch.deltaPosition;

                if (lastTouchPosition.HasValue)
                {
                    Vector2 panDelta = (lastTouchPosition.Value - touch.position) * panSpeed * Time.deltaTime;
                    transform.Translate(panDelta.x, panDelta.y, 0);
                }

                lastTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                lastTouchPosition = null;
            }
        }
    }
}
