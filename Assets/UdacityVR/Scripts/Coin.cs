using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    // TODO: Create variables to reference the game objects we need access to
    // Declare a GameObject named 'coinPoofPrefab' and assign the 'CoinPoof' prefab to the field in Unity

    public GameObject coinPoofPrefab;
    bool isClicked = false;
    bool isMoving = true;
    float y;
    float pY;
    float yInitial;
    float currentTime;

    void Start()
    {
        yInitial = transform.position.y;
    }

    void Update () {
        // OPTIONAL-CHALLENGE: Animate the coin rotating
        // TIP: You could use a method from the Transform class
        
        if (isClicked) {
            y = 7 + (Mathf.Sin(Time.deltaTime));
            
            pY = yInitial + Mathf.Sin((Time.time - currentTime) * 7.0f) * 1.5f;
            transform.Rotate(0.0f, y, 0.0f);
            transform.position = new Vector3(transform.position.x, pY, transform.position.z);

            if (pY < yInitial)
            {
                
                createCoinPoof();
                Object.Destroy(this.gameObject);
                isClicked = false;
            }

        }
        if (isMoving)
        {
            pY = yInitial + (Mathf.Sin(Time.time * 2.1f) * 0.07f);
            transform.position = new Vector3(transform.position.x, pY, transform.position.z);
        }
    }


	public void OnCoinClicked () {
		/// Called when the 'Coin' game object is clicked
		/// - Displays a poof effect (handled by the 'CoinPoof' prefab)
		/// - Plays an audio clip (handled by the 'CoinPoof' prefab)
		/// - Removes the coin from the scene

		// Prints to the console when the method is called
		Debug.Log ("'Coin.OnCoinClicked()' was called");

        // TODO: Display the poof effect and remove the coin from the scene
        // Use Instantiate() to create a clone of the 'CoinPoof' prefab at this coin's position and with the 'CoinPoof' prefab's rotation
        // Use Destroy() to delete the coin after for example 0.5 seconds
        this.isClicked = true;
        this.isMoving = false;
        this.yInitial = transform.position.y;
        this.currentTime = Time.time;
        
    }  

    private void createCoinPoof()
    {
        Object.Instantiate(coinPoofPrefab, transform.position, Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.y)));
    }
}
