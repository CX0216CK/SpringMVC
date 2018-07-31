package cn.rainmanage.service;

import java.util.List;

import cn.rainmanage.entity.RainManage;

/**
 * 2018年6月21日 王 鸿 Administrator
 */
public interface IRainManageservice {
	// 列表
	public List<RainManage> findall() throws Exception;

	// 删除
	public int delete(int id) throws Exception;

	// 新增
	public int insert(RainManage rainManage) throws Exception;
}
