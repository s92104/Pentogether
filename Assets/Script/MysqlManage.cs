using UnityEngine;
using MysqlAccess;

public class MysqlManage : MonoBehaviour {
    public string connectString;

    // Use this for initialization
    void Start () {
        Access.setConnectString(connectString);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
