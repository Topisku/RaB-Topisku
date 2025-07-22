using TMPro;
using UnityEngine;

public class ConfettiScript : MonoBehaviour
{
    public ParticleSystem confettiFx;
    public GameObject Wintext;
    public GameObject player;
    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player)
        {
            transform.position = player.transform.position + offset;
        }

    }
}
