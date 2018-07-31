package cn.rainmanage.entity;

/**
 * 2018年6月21日 王 鸿 Administrator
 */
public class RainManage {
	private int id;
	private String districtName;
	private String monitorTime;
	private int rain;
	private String monitoringStation;
	private String monitoringAddress;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getDistrictName() {
		return districtName;
	}

	public void setDistrictName(String districtName) {
		this.districtName = districtName;
	}

	public String getMonitorTime() {
		return monitorTime;
	}

	public void setMonitorTime(String monitorTime) {
		this.monitorTime = monitorTime;
	}

	public int getRain() {
		return rain;
	}

	public void setRain(int rain) {
		this.rain = rain;
	}

	public String getMonitoringStation() {
		return monitoringStation;
	}

	public void setMonitoringStation(String monitoringStation) {
		this.monitoringStation = monitoringStation;
	}

	public String getMonitoringAddress() {
		return monitoringAddress;
	}

	public void setMonitoringAddress(String monitoringAddress) {
		this.monitoringAddress = monitoringAddress;
	}
}
