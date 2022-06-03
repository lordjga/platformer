using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PixelCrew
{
	public class HeroInputReader : MonoBehaviour
	{
		[SerializeField] private Hero _hero;
		
		public void OnMovement(InputAction.CallbackContext context)
		{
			var position = context.ReadValue<Vector2>();
			_hero.SetDirection(position);
		}
		public void OnSayHello(InputAction.CallbackContext context)
		{
			if (context.canceled)
			_hero.SaySomething();
		}



		//   private void Awake()//���������� ������ ����
		//{
		//	Debug.Log("Awake");
		//}
		//private void OnEnable()
		//{
		//	Debug.Log("OnEnable");
		//}
		//private void Start()
		//{
		//	Debug.Log("Start");
		//}
		//private void FixedUpdate()//����� ���������� ��� ������
		//{
		//	Debug.Log("FixedUpdate");
		//}
		//private void Update()//���������� ������ ����
		//{
		//	Debug.Log("Update");
		//}
		//private void LateUpdate()//����� ��������� ���� update-�
		//{
		//	Debug.Log("LateUpdate");
		//}
		//private void OnDisable()//����� ��������� ��� ���������� gameobject
		//{
		//	Debug.Log("OnDisable");
		//}
		//private void OnDestroy()
		//{
		//	Debug.Log("OnDestroy");
		//}
	}
}

