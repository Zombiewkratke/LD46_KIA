using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour
{
    [System.Serializable]
    public class RandomRooms
    {
        public GameObject Room;
        public float rarity;
    }
    public Vector2 nextRoomPlace;
    public int roomsNumber;
    public List<RandomRooms> DungeonList = new List<RandomRooms>();
    void Start()
    {
       for(int i = roomsNumber;i > 0;i--)
        {
            Instantiate(DungeonList[0].Room, nextRoomPlace, Quaternion.identity);
            nextRoomPlace.x += 18.75f;
            /*
            int rng = Random.Range(0,100);
            for(int j = 0;j < DungeonList.Count; j++)
            {
                if(DungeonList[j].rarity < rng)
                {
                    
                }
            }
            
            */
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
