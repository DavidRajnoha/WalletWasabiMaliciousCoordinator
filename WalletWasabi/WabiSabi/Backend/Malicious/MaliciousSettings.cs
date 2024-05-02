using System.Diagnostics.CodeAnalysis;

namespace WalletWasabi.WabiSabi.Backend.Malicious;

public sealed class MaliciousSettings
{
	[SetsRequiredMembers]
	public MaliciousSettings(bool stepOutputRegistrationEndRandom, bool timingAttack)
	{
		StepOutputRegistrationEndRandom = stepOutputRegistrationEndRandom;
		TimingAttack = timingAttack;
	}

	public required bool StepOutputRegistrationEndRandom { get; set; } = false;
	public required bool TimingAttack { get; set; } = false;


	public static MaliciousSettings Create(
		WabiSabiConfig config)
	{
		return new MaliciousSettings(config.MaliciousRandom, false);
	}
}
