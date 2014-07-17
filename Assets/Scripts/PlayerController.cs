using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

    public float speed;
    public GUIText countText;
    public GUIText winText;
    private int count;

    void Start() {

        count = 0;
        UpdateGUIText();
        winText.text = " ";
    }

    void FixedUpdate()
    {

        float moveHorizontal = Input.acceleration.x;
        float moveVertical = Input.acceleration.y;

        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);

        rigidbody.AddForce(movement*speed*Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "pENID")
        {
            other.gameObject.SetActive(false);
            count += 1;
            UpdateGUIText();
            
        }
    }
    void UpdateGUIText() {
        countText.text = "Count: " + count.ToString();
        if (count >= 8) {
            winText.text = "YOU LOSE. All cubes gone :(";

        }
        
    }
}
