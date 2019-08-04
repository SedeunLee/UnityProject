//////////////////////////////////////////////////////
//                                                  //
//                   EVENT MANAGER                  //
//                                                  //
//////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventMgrClass : MonoBehaviour
{
    // Singleton
    public static EventMgrClass _instance = null;

    // Timer
    private WaitForSeconds waitSec = new WaitForSeconds(300.0f);
    
    private GameObject events;
    private GameObject[] _event;

    private void Awake()
    {
        // Keep Event On Load Scene
        if(_instance == null)
            _instance = this;
        else
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        StartCoroutine("Timer");

        Initialize();
    }

    //
    // Initialize
    //
    private void Initialize()
    {
        // Get events
        events = GameObject.Find("Events");

        if (events == null)
            Debug.Log("Can't find events Object");

        _event = GameObject.FindGameObjectsWithTag("EVENT");

        if (_event == null)
            Debug.Log("Can't find EVENT tag Object");
    }

    // Manage events active
    public void SetEventsActive(bool active)
    {
        events.SetActive(active);
    }

    // Timer Coroutine
    IEnumerator Timer()
    {
        while (true)
        {
            yield return waitSec;

            Debug.Log("Change Event");

            foreach(GameObject evt in _event)
            {
                evt.SetActive(true);
                evt.SendMessage("InitEventInfo");
            }
        }
    }
}
