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
        ServerConnect();//서버 연결
    }
    public void ServerConnect()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster(); //포톤 서버에 연결된 후 자동으로 호출되는 콜백 메서드
        RoomOptions roomOptions = new RoomOptions(); 
        roomOptions.MaxPlayers = 20; //최대인원

        PhotonNetwork.JoinOrCreateRoom("skyroom", roomOptions, TypedLobby.Default); 
        //해당 방에 참여하거나, 해당 방이 없으면 새로 생성하는 명령( 방이름 , 방의 속성(최대인원), 로비유형)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
