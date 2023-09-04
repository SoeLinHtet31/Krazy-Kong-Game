using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT19Main : MonoBehaviour
{
    public static int NFt19Amount;

    private void Awake()
    {
        NFt19Amount = PlayerPrefs.GetInt("NFt19Amount", 0);
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
