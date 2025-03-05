#pragma once
#include <igcl_api.h>

namespace CtlLibraryHelper {

	const int tableNumPoints = 6;

	ctl_result_t CTL_APICALL SetFlatFanSpeedTable(ctl_fan_handle_t fanHandle, ctl_fan_speed_table_t* table, int speedPercent);
}


