package cn.rainmanage.dao.impl;

import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

import cn.rainmanage.dao.BaseDao;
import cn.rainmanage.dao.IRainManage;
import cn.rainmanage.entity.RainManage;

/**
 * 2018年6月21日 王 鸿 Administrator
 */
public class IRainManageimpl extends BaseDao implements IRainManage {

	@Override
	public List<RainManage> findall() throws Exception {
		List<RainManage> list = new ArrayList<RainManage>();
		String sql = "SELECT * FROM`rainquality`";
		ResultSet rs = executeQuery(sql);
		if (rs != null) {
			while (rs.next()) {
				RainManage irainmanage = new RainManage();
				irainmanage.setId(rs.getInt("id"));
				irainmanage.setDistrictName(rs.getString("districtNam"));
				irainmanage.setMonitorTime(rs.getString("monitorTime"));
				irainmanage.setRain(rs.getInt("rain"));
				irainmanage.setMonitoringStation(rs
						.getString("monitoringStation"));
				irainmanage.setMonitoringAddress(rs
						.getString("monitoringAddress"));
				list.add(irainmanage);
			}
		}
		return list;
	}

	@Override
	public int delete(int id) throws Exception {
		String sql = "delete FROM`rainquality` where id=?";
		return executeUpdate(sql, id);
	}

	@Override
	public int insert(RainManage rainManage) throws Exception {
		String sql = "insert `rainquality`(`districtNam`,`monitorTime`,`rain`,`monitoringStation`,`monitoringAddress`)value(?,?,?,?,?)";
		Object[] objects = { rainManage.getDistrictName(),
				rainManage.getMonitorTime(), rainManage.getRain(),
				rainManage.getMonitoringStation(),
				rainManage.getMonitoringAddress() };
		return executeUpdate(sql, objects);
	}
}
