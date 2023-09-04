using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT75Main : MonoBehaviour
{
    public static int NFt75Amount;

    private void Awake()
    {
        NFt75Amount = PlayerPrefs.GetInt("NFt75Amount", 0);
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
