﻿/*
 * Copyright 2012-2013 inBloom, Inc. and its affiliates.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InBloomClient.Entities
{
    /// <summary>
    /// This entity holds the score and or performance levels earned for an objective assessment by a student.
    /// </summary>
    public class StudentObjectiveAssessment
    {
        /// <summary>
        /// This entity represents subtests that assess specific learning objectives.
        /// </summary>
        public ObjectiveAssessment objectiveAssessment { get; set; }

        /// <summary>
        /// This descriptor defines various levels or thresholds for performance on the assessment.
        /// </summary>
        public List<PerformanceLevelDescriptor> performanceLevelDescriptors {get; set;}

        /// <summary>
        /// A meaningful score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc.
        /// </summary>
        public List<ScoreResult> scoreResults { get; set; }
    }
}