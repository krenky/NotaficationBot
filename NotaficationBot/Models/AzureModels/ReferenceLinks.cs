using Microsoft.VisualStudio.Services.WebApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;

namespace NotificationsBot.Models.AzureModels;

[JsonConverter(typeof(ReferenceLinksConverter))]
public class ReferenceLinks
{
    //
    // Сводка:
    //     The json converter to represent the reference links as a dictionary.
    private class ReferenceLinksConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ReferenceLinks);
        }

        //
        // Сводка:
        //     Because ReferenceLinks is a dictionary of either a single ReferenceLink or an
        //     array of ReferenceLinks, we need custom deserialization to correctly rebuild
        //     the dictionary.
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Dictionary<string, object> dictionary = serializer.Deserialize<Dictionary<string, object>>(reader);
            if (dictionary == null)
            {
                return null;
            }

            Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
            foreach (KeyValuePair<string, object> item in dictionary)
            {
                if (string.IsNullOrEmpty(item.Key))
                {
                    throw new JsonSerializationException(/*WebApiResources.InvalidReferenceLinkFormat()*/);
                }

                if (item.Value is JToken { Type: var type } jToken)
                {
                    switch (type)
                    {
                        case JTokenType.Array:
                            {
                                using (JsonReader reader3 = jToken.CreateReader())
                                {
                                    dictionary2[item.Key] = serializer.Deserialize<IList<ReferenceLink>>(reader3);
                                }

                                break;
                            }
                        case JTokenType.Object:
                            {
                                using (JsonReader reader2 = jToken.CreateReader())
                                {
                                    dictionary2[item.Key] = serializer.Deserialize<ReferenceLink>(reader2);
                                }

                                break;
                            }
                        default:
                            throw new JsonSerializationException(/*WebApiResources.InvalidReferenceLinkFormat()*/);
                    }
                }
                else
                {
                    if (!(item.Value is ReferenceLink) && !(item.Value is IList<ReferenceLink>))
                    {
                        throw new JsonSerializationException(/*WebApiResources.InvalidReferenceLinkFormat()*/);
                    }

                    dictionary2[item.Key] = item.Value;
                }
            }

            return new ReferenceLinks
            {
                referenceLinks = dictionary2
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((ReferenceLinks)value).referenceLinks);
        }
    }

    //
    // Сводка:
    //     The internal representation of the reference links.
    private IDictionary<string, object> referenceLinks = new Dictionary<string, object>();

    //
    // Сводка:
    //     The readonly view of the links. Because Reference links are readonly, we only
    //     want to expose them as read only.
    public IReadOnlyDictionary<string, object> Links => new ReadOnlyDictionary<string, object>(referenceLinks);
}