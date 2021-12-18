﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalRegister.MVVM.Model.Mappers
{
    public static class ScheduleCardMapper
    {
        public static ScheduleCard GetScheduleCard(Dictionary<string, string> data)
        {
            var municipalities = new Municipalities
            {
                Id = int.Parse(data["Municipalities.Id"]),
                Name = data["Municipalities.Name"],
                LocalGovernment = data["Municipalities.LocalGoverment"]
            };

            var organization = new Organization
            {
                Id = int.Parse(data["Organization.Id"]),
                Name = data["Organization.Name"]
            };

            return new ScheduleCard()
            {
                Id = int.Parse(data["Id"]),
                Date = DateTime.Parse(data["Date"]),
                District = data["District"],
                Locality = data["Locality"],
                Status = data["Status"],
                StatusDate = DateTime.Parse(data["StatusDate"]),
                OrganizationId = organization,
                MunicipalityId = municipalities
            };
        }

        public static Dictionary<string, string> GetResult(ScheduleCard scheduleCard)
        {
            return DataGenerator.GenerateScheduleDataModel(
                scheduleCard.Id.ToString(),
                scheduleCard.Date.ToString(), 
                scheduleCard.District,
                scheduleCard.Locality, 
                scheduleCard.Status, 
                scheduleCard.StatusDate.ToString(),
                scheduleCard.OrganizationId.Id.ToString(),
                scheduleCard.OrganizationId.Name,
                scheduleCard.MunicipalityId.Id.ToString(),
                scheduleCard.MunicipalityId.Name,
                scheduleCard.MunicipalityId.LocalGovernment
                );
        }
    }
}
