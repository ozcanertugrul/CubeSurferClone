using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float ileriGitmeHizi;
    [SerializeField]
    private float sagaSolaGitmeHizi;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * sagaSolaGitmeHizi * Time.deltaTime;
        this.transform.Translate(yatayEksen, 0, ileriGitmeHizi * Time.deltaTime);

    }
}
