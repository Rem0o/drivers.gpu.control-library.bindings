#include "CtlLibraryHelper.h"

ctl_result_t CTL_APICALL CtlLibraryHelper::SetFlatFanSpeedTable(ctl_fan_handle_t fanHandle, ctl_fan_speed_table_t* table, int speedPercent)
{
	// setup the table if not already done
	if (table->numPoints != tableNumPoints)
	{
		table->numPoints = tableNumPoints;

		ctl_fan_temp_speed_t* pair;
		for (int i = 0; i < table->numPoints; i++)
		{
			pair = &table->table[i];
			pair->Size = sizeof(ctl_fan_temp_speed_t);
			pair->temperature = ((i + 1) * 20);
			pair->speed.units = CTL_FAN_SPEED_UNITS_PERCENT;
			pair->speed.Size = sizeof(ctl_fan_speed_t);
		}
	}

	// apply
	for (int i = 0; i < table->numPoints; i++)
	{
		table->table[i].speed.speed = speedPercent;
	}

	return ctlFanSetSpeedTableMode(fanHandle, table);
}
