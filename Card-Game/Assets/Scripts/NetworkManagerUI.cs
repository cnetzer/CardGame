using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : NetworkBehaviour
{
    [SerializeField] private Button startServerBtn;
    [SerializeField] private Button startHostBtn;
    [SerializeField] private Button startClientBtn;

    private void Awake()
    {
        startServerBtn.onClick?.AddListener(() => NetworkManager.StartServer());
        startHostBtn.onClick?.AddListener(() => NetworkManager.StartHost());
        startClientBtn.onClick?.AddListener(() => NetworkManager.StartClient());
    }

    public void ToggleNetworkManagerUI()
    {
        startServerBtn.gameObject.SetActive(!startServerBtn.gameObject.activeSelf);
        startHostBtn.gameObject.SetActive(!startHostBtn.gameObject.activeSelf);
        startClientBtn.gameObject.SetActive(!startClientBtn.gameObject.activeSelf);
    }
}
