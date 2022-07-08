using System.Resources;

namespace VocaDb.Model.Service.BrandableStrings.Collections;

public abstract class ResStringCollection
{
	private static string? EmptyToNull(string? str)
	{
		return str == string.Empty ? null : str;
	}

	protected ResStringCollection(ResourceManager resourceManager)
	{
		ResourceManager = resourceManager;
	}

	public ResourceManager ResourceManager { get; }

	protected string? GetString(string name) => ResourceManager.GetString(name);

	protected string GetString(string name, string fallback) => EmptyToNull(GetString(name)) ?? fallback;
}
