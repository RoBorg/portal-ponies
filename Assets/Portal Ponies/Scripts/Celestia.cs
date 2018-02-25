using UnityEngine;

public class Celestia : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, -50, 0);
    }
}
