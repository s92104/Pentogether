using UnityEngine;
using MysqlAccess;

public class MysqlManage : MonoBehaviour {
    public string connectString;
    public GameObject noConnectWindow;

    // Use this for initialization
    void Start () {
        Access.setConnectString(connectString);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void checkConnect()
    {
        if (!Access.isConnect())
            noConnectWindow.SetActive(true);
    }


}
