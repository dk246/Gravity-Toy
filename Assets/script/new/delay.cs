using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delay : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("creditOff");
    }

    IEnumerator creditOff()
    {
        yield return new WaitForSeconds(2.5f);
        panel.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
