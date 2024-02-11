
public sealed class MyComponent : Component
{
	[Property] public GameObject Test { get; set; }

	protected override void OnAwake()
	{
		var x = Test.Clone( Transform.Position, Rotation.Identity );
	}
}
