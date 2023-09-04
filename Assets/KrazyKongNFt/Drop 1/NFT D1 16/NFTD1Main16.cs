using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFTD1Main16 : MonoBehaviour
{
    public static int NFt16D1Amount;

    private void Awake()
    {
        NFt16D1Amount = PlayerPrefs.GetInt("NFt16D1Amount", 0);
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
