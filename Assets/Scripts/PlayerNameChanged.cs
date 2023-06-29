using System;
using Unity.Entities;
using UnityEngine;

[Serializable]
public class PlayerNameChanged : IComponentData
{
	public IPlayerNameChanged Listener;
}