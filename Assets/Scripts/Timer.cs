using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private int startTime;
    [HideInInspector]public int currentTime;

   public UnityEvent timeСhangedEvent;
   public UnityEvent timeRunOutEvent;
    IEnumerator Start()
    {
        currentTime = startTime;
        while (currentTime > 0)
        {
            timeСhangedEvent?.Invoke();
            yield return new WaitForSeconds(1);
             currentTime--;
        }

timeRunOutEvent?.Invoke();
        yield break;
    }

    
}
