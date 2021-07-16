using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource tickSource;
    public AudioSource treeNoise;
    public AudioSource cowNoise;
    // Start is called before the first frame update
    void Start()
    {
        treeNoise.playOnAwake = false;
        tickSource.playOnAwake = false;
        //tickSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            tickSource.Play();
        }
        if(collision.gameObject.tag == "Nature")
        {
            treeNoise.Play();
        }
        if (collision.gameObject.tag == "Cow")
        {
            cowNoise.Play();
        }
    }
}
