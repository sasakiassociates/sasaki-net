using Sasaki.Common;

namespace Sasaki.Analysis;

[Serializable]
public class ResultLayer : SasakiObject, IResultLayer
{
  /// <inheritdoc />
  public int count => values.Valid() ? values.Count : 0;

  /// <inheritdoc />
  public List<int> values {get;} = new List<int>();

}
