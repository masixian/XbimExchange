﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.COBieLiteUK;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Tests
{
    [TestClass]
    public class COBieLiteUKTests
    {
        [TestMethod]
        public void COBieLiteUKCreation()
        {
            var model = new FacilityStageCollectionType();
            model.FacilityStage = new List<FacilityStageType>();
            model.FacilityStage.AddRange(new []{
                new FacilityStageType(){
                    externalID = Guid.NewGuid().ToString(),
                    FacilityStageCode = "A4",
                    FacilityStageDescription = "Stage A4",
                    FacilityStageName = "Preliminary design",
                    FacilityStageStartDate = DateTime.Now,
                    FacilityStageEndDate = DateTime.Now.AddDays(28),
                    FacilityStageAttributes = new AttributeCollectionType(){
                        Attribute = new List<AttributeType>(new []{
                            new AttributeType1(){
                                AttributeName = "New attribute 1",
                                externalID = Guid.NewGuid().ToString(),
                                AttributeCategory = "Requirement",
                                AttributeValue = new AttributeValueType(){Item = new AttributeStringValueType(){StringValue = "Value AAA"},
                                    ItemElementName = ItemChoiceType.AttributeStringValue}
                            },
                            new AttributeType1(){
                                AttributeName = "New attribute 2",
                                externalID = Guid.NewGuid().ToString(),
                                AttributeCategory = "Requirement",
                                AttributeValue = new AttributeValueType(){Item = new AttributeStringValueType(){StringValue = "Value BBB"},
                                    ItemElementName = ItemChoiceType.AttributeStringValue}
                            }
                        })
                    },
                    Facility = new FacilityType(){
                        externalID = Guid.NewGuid().ToString(),
                        FacilityDefaultAreaUnit = AreaUnitSimpleType.squaremeters,
                        FacilityDefaultAreaUnitSpecified = true,
                        FacilityDefaultCurrencyUnit = CurrencyUnitSimpleType.BritishPounds,
                        FacilityDefaultCurrencyUnitSpecified = true,
                        FacilityDefaultLinearUnit = LinearUnitSimpleType.millimeters,
                        FacilityDefaultLinearUnitSpecified = true,
                        FacilityDefaultMeasurementStandard = "NRM",
                        FacilityDefaultVolumeUnit = VolumeUnitSimpleType.cubicmeters,
                        FacilityDefaultVolumeUnitSpecified = true,
                        FacilityDeliverablePhaseName = "Phase A",
                        FacilityDescription = "New facility description",
                        FacilityName = "Ellison Building",
                        ProjectAssignment = new ProjectType(){externalID = Guid.NewGuid().ToString(), ProjectName = "Project A"},
                        SiteAssignment = new SiteType(){externalID = Guid.NewGuid().ToString(), SiteName = "Site A"},
                        Zones = new ZoneCollectionType(){Zone = new List<ZoneType>(new []{
                            new ZoneType1(){
                                externalID = Guid.NewGuid().ToString(),
                                ZoneName = "Zone A",
                                ZoneCategory = "45.789.78",
                                ZoneDescription = "Description of the zone A"
                            }
                        })}
                    }
                },
                new FacilityStageType(){
                    externalID = Guid.NewGuid().ToString(),
                    FacilityStageCode = "A4",
                    FacilityStageDescription = "Stage A4",
                    FacilityStageName = "Preliminary design",
                    FacilityStageStartDate = DateTime.Now,
                    FacilityStageEndDate = DateTime.Now.AddDays(28),
                    FacilityStageAttributes = new AttributeCollectionType(){
                        Attribute = new List<AttributeType>(new []{
                            new AttributeType1(){
                                AttributeName = "New attribute 1",
                                externalID = Guid.NewGuid().ToString(),
                                AttributeCategory = "Requirement",
                                AttributeValue = new AttributeValueType(){Item = new AttributeStringValueType(){StringValue = "Value AAA"},
                                    ItemElementName = ItemChoiceType.AttributeStringValue}
                            },
                            new AttributeType1(){
                                AttributeName = "New attribute 2",
                                externalID = Guid.NewGuid().ToString(),
                                AttributeCategory = "Requirement",
                                AttributeValue = new AttributeValueType(){Item = new AttributeStringValueType(){StringValue = "Value BBB"},
                                    ItemElementName = ItemChoiceType.AttributeStringValue}
                            }
                        })
                    },
                    Facility = new FacilityType(){
                        externalID = Guid.NewGuid().ToString(),
                        FacilityDefaultAreaUnit = AreaUnitSimpleType.squaremeters,
                        FacilityDefaultAreaUnitSpecified = true,
                        FacilityDefaultCurrencyUnit = CurrencyUnitSimpleType.BritishPounds,
                        FacilityDefaultCurrencyUnitSpecified = true,
                        FacilityDefaultLinearUnit = LinearUnitSimpleType.millimeters,
                        FacilityDefaultLinearUnitSpecified = true,
                        FacilityDefaultMeasurementStandard = "NRM",
                        FacilityDefaultVolumeUnit = VolumeUnitSimpleType.cubicmeters,
                        FacilityDefaultVolumeUnitSpecified = true,
                        FacilityDeliverablePhaseName = "Phase A",
                        FacilityDescription = "New facility description",
                        FacilityName = "Ellison Building",
                        ProjectAssignment = new ProjectType(){externalID = Guid.NewGuid().ToString(), ProjectName = "Project A"},
                        SiteAssignment = new SiteType(){externalID = Guid.NewGuid().ToString(), SiteName = "Site A"},
                        Zones = new ZoneCollectionType(){Zone = new List<ZoneType>(new []{
                            new ZoneType1(){
                                externalID = Guid.NewGuid().ToString(),
                                ZoneName = "Zone A",
                                ZoneCategory = "45.789.78",
                                ZoneDescription = "Description of the zone A"
                            }
                        })}
                    }
                },
                new FacilityStageType(){
                    externalID = Guid.NewGuid().ToString(),
                    FacilityStageCode = "A4",
                    FacilityStageDescription = "Stage A4",
                    FacilityStageName = "Preliminary design",
                    FacilityStageStartDate = DateTime.Now,
                    FacilityStageEndDate = DateTime.Now.AddDays(28),
                    FacilityStageAttributes = new AttributeCollectionType(){
                        Attribute = new List<AttributeType>(new []{
                            new AttributeType1(){
                                AttributeName = "New attribute 1",
                                externalID = Guid.NewGuid().ToString(),
                                AttributeCategory = "Requirement",
                                AttributeValue = new AttributeValueType(){
                                    Item = new AttributeStringValueType(){StringValue = "Value AAA"},
                                    ItemElementName = ItemChoiceType.AttributeStringValue
                                }
                            },
                            new AttributeType1(){
                                AttributeName = "New attribute 2",
                                externalID = Guid.NewGuid().ToString(),
                                AttributeCategory = "Requirement",
                                AttributeValue = new AttributeValueType(){
                                    Item = new AttributeStringValueType(){StringValue = "Value BBB"},
                                    ItemElementName = ItemChoiceType.AttributeStringValue
                                }
                            }
                        })
                    },
                    Facility = new FacilityType(){
                        externalID = Guid.NewGuid().ToString(),
                        FacilityDefaultAreaUnit = AreaUnitSimpleType.squaremeters,
                        FacilityDefaultAreaUnitSpecified = true,
                        FacilityDefaultCurrencyUnit = CurrencyUnitSimpleType.BritishPounds,
                        FacilityDefaultCurrencyUnitSpecified = true,
                        FacilityDefaultLinearUnit = LinearUnitSimpleType.millimeters,
                        FacilityDefaultLinearUnitSpecified = true,
                        FacilityDefaultMeasurementStandard = "NRM",
                        FacilityDefaultVolumeUnit = VolumeUnitSimpleType.cubicmeters,
                        FacilityDefaultVolumeUnitSpecified = true,
                        FacilityDeliverablePhaseName = "Phase A",
                        FacilityDescription = "New facility description",
                        FacilityName = "Ellison Building",
                        ProjectAssignment = new ProjectType(){externalID = Guid.NewGuid().ToString(), ProjectName = "Project A"},
                        SiteAssignment = new SiteType(){externalID = Guid.NewGuid().ToString(), SiteName = "Site A"},
                        Zones = new ZoneCollectionType(){Zone = new List<ZoneType>(new []{
                            new ZoneType1(){
                                externalID = Guid.NewGuid().ToString(),
                                ZoneName = "Zone A",
                                ZoneCategory = "45.789.78",
                                ZoneDescription = "Description of the zone A"
                            }
                        })}
                    }
                }
            });
            using (var file = File.Create("test.xml"))
            {
                model.Save(file);
                file.Close();                
            }
        }
    }
}
