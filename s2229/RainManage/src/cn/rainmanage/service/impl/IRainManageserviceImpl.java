package cn.rainmanage.service.impl;

import java.util.List;

import cn.rainmanage.dao.IRainManage;
import cn.rainmanage.dao.impl.IRainManageimpl;
import cn.rainmanage.entity.RainManage;
import cn.rainmanage.service.IRainManageservice;

/**
 * 2018年6月21日 王 鸿 Administrator
 */
public class IRainManageserviceImpl implements IRainManageservice {
	IRainManage irinmanage = new IRainManageimpl();

	@Override
	public List<RainManage> findall() throws Exception {
		// TODO Auto-generated method stub
		return irinmanage.findall();
	}

	@Override
	public int delete(int id) throws Exception {

		return irinmanage.delete(id);
	}

	@Override
	public int insert(RainManage rainManage) throws Exception {
		// TODO Auto-generated method stub
		return irinmanage.insert(rainManage);
	}

}
