﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace TelegramExportProcessor;

internal class CompletTextJsonConverter : JsonConverter<CompletText>
{
    public override CompletText Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        throw new NotImplementedException();
        //return DateTimeOffset.ParseExact(reader.GetString()!,
        //        "MM/dd/yyyy", CultureInfo.InvariantCulture);
    }

    public override void Write(
        Utf8JsonWriter writer,
        CompletText dateTimeValue,
        JsonSerializerOptions options)
    {
        throw new NotImplementedException();
        //writer.WriteStringValue(dateTimeValue.ToString(
        //        "MM/dd/yyyy", CultureInfo.InvariantCulture));
    }
}