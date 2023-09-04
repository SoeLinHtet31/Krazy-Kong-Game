using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFTD1Main18 : MonoBehaviour
{
    public static int NFt18D1Amount;

    private void Awake()
    {
        NFt18D1Amount = PlayerPrefs.GetInt("NFt18D1Amount", 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
