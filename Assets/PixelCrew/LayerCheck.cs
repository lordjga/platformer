using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerCheck : MonoBehaviour
{
    //������ ����������� � ��� ����� ������������� (��� ������)
    //��������� ����� gameobject � HERO � ��� ����������� ���������,
    //� ���� ����

    [SerializeField] private LayerMask _groundLayer;
    private Collider2D _collider;
	public bool isTouchingLayer;

	//�����������, ����� � ���� �������� ������ ���������� �������� ������ ��������� 
	private void OnTriggerStay2D(Collider2D collision)
	{
		isTouchingLayer = _collider.IsTouchingLayers(_groundLayer);
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		
	}
}
