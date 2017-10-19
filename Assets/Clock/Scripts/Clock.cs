using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour {

	//-- set start time 00:00
    public int minutes = 0;
    public int hour = 0;
	public float seconds = 0.0f;
	public bool realTime=true;
	
	public GameObject pointerSeconds;
    public GameObject pointerMinutes;
    public GameObject pointerHours;
    
    //-- time speed factor
    public float clockSpeed = 1.0f;     // 1.0f = realtime, < 1.0f = slower, > 1.0f = faster

    //-- internal vars
    float msecs=0;

void Start() 
{
	//-- set real time
	if (realTime)
	{
		hour=System.DateTime.Now.Hour;
		minutes=System.DateTime.Now.Minute;
//		seconds=System.DateTime.Now.Second;
	}
}

void Update() 
{
    //-- calculate time
    msecs += Time.deltaTime * clockSpeed*5.0f;
    if(msecs >= 0.01f)
    {
        msecs -= 0.01f;
//        seconds+=0.01f;
//        if(seconds >= 60)
//        {
//            seconds = 0;
//            minutes++;
//            if(minutes > 60)
//            {
//                minutes = 0;
//                hour++;
//                if(hour >= 24)
//                    hour = 0;
//            }
//        }
    }

		seconds+=0.15f;
		if(seconds >= 60)
		{
			seconds = 0;
			minutes++;
			if(minutes > 60)
			{
				minutes = 0;
				hour++;
				if(hour >= 24)
					hour = 0;
			}
		}


    //-- calculate pointer angles
    float rotationSeconds = (360.0f / 60.0f)  * seconds;
    float rotationMinutes = (360.0f / 60.0f)  * minutes;
    float rotationHours   = ((360.0f / 12.0f) * hour) + ((360.0f / (60.0f * 12.0f)) * minutes);

    //-- draw pointers
    pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationSeconds);
    pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationMinutes);
    pointerHours.transform.localEulerAngles   = new Vector3(0.0f, 0.0f, rotationHours);

}
}
