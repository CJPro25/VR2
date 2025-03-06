using UnityEngine;
public class VaseBreak : MonoBehaviour
{
    public GameObject vase;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Breakable")
        {
            Instantiate(vase, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
