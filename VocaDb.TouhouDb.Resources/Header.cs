using VocaDb.Model.Service.BrandableStrings;
using VocaDb.Model.Service.BrandableStrings.Collections;
using VocaDb.TouhouDb.Resources.ViewRes;

namespace VocaDb.TouhouDb.Resources;

public class Header : IBrandedStringsAssemblyHeader
{
	public AlbumStrings Album => new(AlbumRes.ResourceManager);

	public ArtistStrings Artist => new(ArtistRes.ResourceManager);

	public HomeStrings Home => new(HomeRes.ResourceManager);

	public LayoutStrings Layout => new(LayoutRes.ResourceManager);

	public SongStrings Song => new(SongRes.ResourceManager);

	public UserStrings User => new(UserRes.ResourceManager);
}
