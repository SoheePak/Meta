using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        ServerConnect();//���� ����
    }
    public void ServerConnect()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster(); //���� ������ ����� �� �ڵ����� ȣ��Ǵ� �ݹ� �޼���
        RoomOptions roomOptions = new RoomOptions(); 
        roomOptions.MaxPlayers = 20; //�ִ��ο�

        PhotonNetwork.JoinOrCreateRoom("skyroom", roomOptions, TypedLobby.Default); 
        //�ش� �濡 �����ϰų�, �ش� ���� ������ ���� �����ϴ� ���( ���̸� , ���� �Ӽ�(�ִ��ο�), �κ�����)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
