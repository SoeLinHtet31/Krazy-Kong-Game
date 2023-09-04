using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT38Main : MonoBehaviour
{
    public static int NFt38Amount;

    private void Awake()
    {
        NFt38Amount = PlayerPrefs.GetInt("NFt38Amount", 0);
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
