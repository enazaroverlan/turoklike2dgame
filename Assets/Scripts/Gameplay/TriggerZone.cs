using UnityEngine;
using System.Collections;

public class TriggerZone : MonoBehaviour
{
    public GameObject player;

    public void Start()
    {
        //player = GameObject.FindWithTag("Player");
    }

    void OnEnable()
    {
        Subscribe();
    }

    void OnDisable()
    {
        Unsubscribe();
    }

    void Subscribe()
    {
        EasyTouch.On_SwipeStart += On_SwipeStart;
        EasyTouch.On_Swipe += On_Swipe;
        EasyTouch.On_SwipeEnd += On_SwipeEnd;
    }

    void Unsubscribe()
    {
        EasyTouch.On_SwipeStart -= On_SwipeStart;
        EasyTouch.On_Swipe -= On_Swipe;
        EasyTouch.On_SwipeEnd -= On_SwipeEnd;
    }

    public void On_SwipeStart(Gesture swipeStart)
    {
        /*Vector3 pos = Camera.main.ScreenToWorldPoint(swipeStart.position);
        Debug.DrawLine(player.transform.position, pos, Color.red);*/
    }

    public void On_Swipe(Gesture swipe)
    {
        Debug.Log("On_Swipe");

        Vector3 pos = Camera.main.ScreenToWorldPoint(swipe.position);
        Debug.DrawLine(player.transform.position, pos, Color.red);
    }

    public void On_SwipeEnd(Gesture swipeEnd)
    {

    }
}
