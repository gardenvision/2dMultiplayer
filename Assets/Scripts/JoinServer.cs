using Unity.Netcode;
using UnityEngine;

public class JoinServer : MonoBehaviour
{
    public void Join(){ 
        // This method will be called when the player clicks the "Join" button
        Debug.Log("Join button clicked. Implement server joining logic here.");
        
        // Example: Load a new scene or connect to a server
        // SceneManager.LoadScene("GameScene");
         NetworkManager.Singleton.StartClient();
    }
    
    private void Start()
    {
        NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnected;
        NetworkManager.Singleton.OnClientDisconnectCallback += OnClientDisconnected;
    }

    private void OnClientConnected(ulong clientId)
    {
        Debug.Log($"Client {clientId} connected");
    }

    private void OnClientDisconnected(ulong clientId)
    {
        Debug.Log($"Client {clientId} disconnected");
    }
    
}
