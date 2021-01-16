using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerMovement : MonoBehaviour
{
	public MoveControl leftButton, rightButton;
    public float speed;
    public GameObject bullet, bulletPosition;
    public static bool perisaiActive;
    void Start()
    {
        perisaiActive = false;
    }
    // Update is called once per frame
    void Update()
    {
        float dirX = CrossPlatformInputManager.GetAxis("Horizontal");
		
		moveleft ();
		moveright ();
    }
	public void shoot ()
	{
		 Instantiate(bullet, bulletPosition.transform.position, bulletPosition.transform.rotation);
	}
	public void moveleft ()
	{
		if (leftButton.IsPressed())
		transform.Translate(new Vector2(-1 * speed * Time.deltaTime, 0));
	}
	public void moveright ()
	{
		if (rightButton.IsPressed())
		transform.Translate(new Vector2(1 * speed * Time.deltaTime, 0));
	}
	
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Perisai")
        {
            Destroy(collision.gameObject);
            DataScore.perisai += 1;
        }
    }
}
