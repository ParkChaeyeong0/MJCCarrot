using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{/*
	public float m_TotalSeconds = 30; //45초

	public string m_Timer = @"00";

	public KeyCode m_TimerPlay = KeyCode.Space;

	private bool m_IsPlaying;

	public Text Timer_text;

	public GameObject LockImage;

	// Start is called before the first frame update
	void Start()
	{
		m_Timer = CountdownTimer(false); // Text에 초기값을 넣어 주기 위해
	}

	// Update is called once per frame
	void Update()
	{
		m_Timer = CountdownTimer();
		// m_TotalSeconds이 줄어들때, 완전히 0에 맞출수 없기 때문에 
		if (m_TotalSeconds <= 0)
		{
			SetZero();
			LockImage.SetActive(false);
		}

		if (Timer_text)
			Timer_text.text = m_Timer;
	}

	string CountdownTimer(bool IsUpdate = true)
	{
		if (IsUpdate)
			m_TotalSeconds -= Time.deltaTime;
		TimeSpan timeSpan = TimeSpan.FromSeconds(m_TotalSeconds);
		string timer = string.Format("{0:00}:{1:00}", timeSpan.Minutes, timeSpan.Seconds);

		return timer;

	}
	private void SetZero()
	{
		m_Timer = @"00";
		m_TotalSeconds = 0;
		m_IsPlaying = false;
	}*/
}
