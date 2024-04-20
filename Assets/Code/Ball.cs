using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Text shotsText;
    


    [Header("Attributes")]
    [SerializeField] private float maxPower = 10f;
    [SerializeField] private float power = 2f;

    private bool isDragging;
    private int shotsCount = 0;
     private void Start()
    {
        UpdateShotsText();
    }

    private void Update()
    {
        PlayerInput();
    }

    private void PlayerInput()
    {
        Vector2 inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distance = Vector2.Distance(transform.position, inputPos);

        if (Input.GetMouseButtonDown(0) && distance <= 0.5f)
            DragStart();
        if (Input.GetMouseButton(0) && isDragging)
            DragChange();
        if (Input.GetMouseButtonUp(0) && isDragging)
            DragRelease(inputPos);
    }

    private void DragStart()
    {
        isDragging = true;
    }

    private void DragChange()
    {
 
    }

    private void DragRelease(Vector2 pos)
    {
        float distance = Vector2.Distance((Vector2)transform.position, pos);
        isDragging = false;
         
        shotsCount++;
        UpdateShotsText();
        
        Vector2 dir = (Vector2)transform.position - pos;
        rb.velocity = Vector2.ClampMagnitude(dir * power, maxPower);
    }
      private void UpdateShotsText()
    {
        if (shotsText != null)
        {
            shotsText.text = "Shots: " + shotsCount.ToString();
        }
    }
}