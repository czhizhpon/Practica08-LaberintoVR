using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    // TODO: Create variables to reference the game objects we need access to
    // Declare a GameObject named 'keyPoofPrefab' and assign the 'KeyPoof' prefab to the field in Unity
    // Declare a Door named 'door' and assign the top level 'Door' game object to the field in Unity

    public GameObject keyPoofPrefab;
    public Door door;

    bool isMoving = true;
    float pY;
    float yInitial;
    float rotation_x;
    float rotation_y;
    float rotation_z;

    void Start()
    {
        rotation_x = transform.rotation.x;
        rotation_y = transform.rotation.y;
        rotation_z = transform.rotation.z;
    }

    void Update () {
        // OPTIONAL-CHALLENGE: Animate the key rotating
        // TIP: You could use a method from the Transform class

        if (isMoving)
        {
            rotation_z = 2 + (Mathf.Sin(Time.deltaTime));
            transform.Rotate(0.0f, 0.0f, rotation_z);
        }
        if (!isMoving)
        {
            rotation_z = 7 + (Mathf.Sin(Time.deltaTime));
            transform.Rotate(0.0f, 0.0f, rotation_z);
        }
    }


	public void OnKeyClicked () {
		/// Called when the 'Key' game object is clicked
		/// - Unlocks the door (handled by the Door class)
		/// - Displays a poof effect (handled by the 'KeyPoof' prefab)
		/// - Plays an audio clip (handled by the 'KeyPoof' prefab)
		/// - Removes the key from the scene

		// Prints to the console when the method is called
		Debug.Log ("'Key.OnKeyClicked()' was called");

        // TODO: Unlock the door, display the poof effect, and remove the key from the scene
        // Use 'door' to call the Door.Unlock() method
        // Use Instantiate() to create a clone of the 'KeyPoof' prefab at this coin's position and with the 'KeyPoof' prefab's rotation
        // Use Destroy() to delete the key after for example 0.5 seconds
        CreateKeyPoof();
        door.Unlock();
        Object.Destroy(this.gameObject, 0.5f);
        isMoving = false;
	}

    private void CreateKeyPoof()
    {
        Object.Instantiate(keyPoofPrefab, transform.position, Quaternion.Euler(
            new Vector3(-transform.rotation.x, transform.rotation.y, 
            transform.rotation.y)));
    }
}
