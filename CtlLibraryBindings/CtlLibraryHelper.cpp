#include "CtlLibraryHelper.h"

ctl_result_t CTL_APICALL CtlLibraryHelper::SetFlatFanSpeedTable(ctl_fan_handle_t fanHandle, ctl_fan_speed_table_t* table, int speedPercent)
{
	// setup the table if not already done
	if (table->numPoints != tableNumPoints)
	{
		table->numPoints = tableNumPoints;
		table->Version = 0;

		for (int i = 0; i < table->numPoints; i++)
		{
			table->table[i] = { 0 };
			table->table[i].Version = 0;
			table->table[i].Size = sizeof(ctl_fan_temp_speed_t);
			table->table[i].temperature = 25 + ((i + 1) * 12);
			table->table[i].speed.Version = 0;
			table->table[i].speed.units = CTL_FAN_SPEED_UNITS_PERCENT;
			table->table[i].speed.Size = sizeof(ctl_fan_speed_t);
		}
	}

	// apply
	for (int i = 0; i < table->numPoints; i++)
	{
		table->table[i].speed.speed = speedPercent;
	}

	return ctlFanSetSpeedTableMode(fanHandle, table);
}
