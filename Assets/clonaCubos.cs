using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonaCubos : MonoBehaviour
{
    public GameObject cuboPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClonarCubos()
    {
        Instantiate(cuboPrefab);
    }
}
