using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerCheck : MonoBehaviour
{
    //способ определения с чем игрок соприкосается (для прыжка)
    //создается новый gameobject в HERO и ему добавляется коллайдер,
    //и этот файл

    [SerializeField] private LayerMask _groundLayer;
    private Collider2D _collider;
	public bool isTouchingLayer;

	//срабатывают, когда в зону действия нашего коллайдера попадает другой коллайдер 
	private void OnTriggerStay2D(Collider2D collision)
	{
		isTouchingLayer = _collider.IsTouchingLayers(_groundLayer);
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		
	}
}
