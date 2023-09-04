using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFTD1Main15 : MonoBehaviour
{
    public static int NFt15D1Amount;

    private void Awake()
    {
        NFt15D1Amount = PlayerPrefs.GetInt("NFt15D1Amount", 0);
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
