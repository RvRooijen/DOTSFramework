using Unity.Burst;
using Unity.Entities;

public partial struct PlayerNameChangedSystem : ISystem
{
	public void OnUpdate(ref SystemState state)
	{
		foreach (var playerNameChanged in SystemAPI.Query<PlayerNameChanged>())
		{
			playerNameChanged.Listener.PlayerNameChanged("Kristen sChat GPT");
		}
	}
}