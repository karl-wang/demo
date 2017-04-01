using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : MonoBehaviour
{
    public GameObject alienPrefab;

    NetworkClient myClient;

    // Create a client and connect to the server port
    public void SetupClient()
    {
        ClientScene.RegisterPrefab(alienPrefab);

        myClient = new NetworkClient();

        myClient.RegisterHandler(MsgType.Connect, OnConnected);
        myClient.Connect("127.0.0.1", 4444);
    }

    void OnConnected(NetworkMessage netMsg)
    {
        Debug.Log("Client connected");
    }
}