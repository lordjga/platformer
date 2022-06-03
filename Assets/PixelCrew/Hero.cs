using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

namespace PixelCrew
{
	public class Hero : MonoBehaviour
	{
		[SerializeField] //����� ���������� public, ���� �����
		private float _speed;
		[SerializeField] 
		private float _jumpSpeed;
		[SerializeField]
		private LayerMask _groundLayer;

		[SerializeField]
		private float _groundCheckRadius;
		[SerializeField]
		private Vector3 _groundCheckPositionDelta;

		private Vector2 _direction;

		private Rigidbody2D _rigidbody;

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
		}

		private void FixedUpdate()
		{
			//������������
			_rigidbody.velocity = new Vector2(_direction.x * _speed, _rigidbody.velocity.y);
			//������
			var isJumping = _direction.y > 0;
			if (isJumping & IsGrounded())//��������� ���������� �� ����������� �������� � �� ����� ��
			{
				_rigidbody.AddForce(Vector2.up * _jumpSpeed, ForceMode2D.Impulse);
			}
		}
		public void SetDirection(Vector2 direction)
		{
			_direction = direction;
		}

		private bool IsGrounded()
		{
			//���������� ������ ��������� � ������� ������������� ���� (�����), �� ������������ ���������, � ������������ �����
			var hit = Physics2D.CircleCast(transform.position + _groundCheckPositionDelta, _groundCheckRadius,  Vector2.down, 0, _groundLayer);
			return hit.collider != null;
		}

		private void OnDrawGizmos()//���������� � ������ ��������� debug ���� �� �����
		{
			//��� ����������� ����� (��� �����), ������� ���������� �� ����� �� ��
			//Debug.DrawLine(transform.position, Vector3.down, IsGrounded() ? Color.green : Color.red);
			Gizmos.color = IsGrounded() ? Color.green : Color.red;
			Gizmos.DrawSphere(transform.position + _groundCheckPositionDelta, _groundCheckRadius);
		}

		//private void Update()
		//{
		//	if (_direction.magnitude > 0)
		//	{
		//		var delta = _direction * _speed * Time.deltaTime;
		//		transform.position = transform.position + new Vector3(delta.x, delta.y, transform.position.z);
		//	}
		//}

		public void SaySomething()
		{
			Debug.Log("Hello!");
		}
		
	}

}
