package cn.rainmanage.dao;

import java.util.List;

import cn.rainmanage.entity.RainManage;

/**
 * 2018��6��21�� �� �� Administrator
 */
public interface IRainManage {
	// �б�
	public List<RainManage> findall() throws Exception;

	// ɾ��
	public int delete(int id) throws Exception;

	// ����
	public int insert(RainManage rainManage) throws Exception;
}
