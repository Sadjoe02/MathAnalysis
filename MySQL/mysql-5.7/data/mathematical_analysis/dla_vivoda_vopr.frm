TYPE=VIEW
query=select `mathematical_analysis`.`voprosi`.`vopros` AS `vopros`,`mathematical_analysis`.`voprosi_testov`.`id_vopr` AS `id_vopr`,`mathematical_analysis`.`voprosi_testov`.`id_tests` AS `id_tests`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`tests`.`id_temi` AS `id_temi`,`mathematical_analysis`.`tests`.`min_colvo_ball` AS `min_colvo_ball`,`mathematical_analysis`.`tests`.`name_test` AS `name_test`,`mathematical_analysis`.`tests`.`id_yrovni` AS `id_yrovni`,`mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel`,`mathematical_analysis`.`voprosi`.`question_for_difficult_test` AS `question_for_difficult_test` from ((((`mathematical_analysis`.`voprosi_testov` join `mathematical_analysis`.`tests` on((`mathematical_analysis`.`voprosi_testov`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`))) join `mathematical_analysis`.`voprosi` on((`mathematical_analysis`.`voprosi_testov`.`id_vopr` = `mathematical_analysis`.`voprosi`.`id_vopr`))) join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`tests`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`))) join `mathematical_analysis`.`razdel` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`)))
md5=fc8372c3d87d1d4b843ed7452f2d9639
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-05-12 09:33:13
create-version=1
source=SELECT
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`voprosi`.`vopros` AS `vopros`,`mathematical_analysis`.`voprosi_testov`.`id_vopr` AS `id_vopr`,`mathematical_analysis`.`voprosi_testov`.`id_tests` AS `id_tests`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`tests`.`id_temi` AS `id_temi`,`mathematical_analysis`.`tests`.`min_colvo_ball` AS `min_colvo_ball`,`mathematical_analysis`.`tests`.`name_test` AS `name_test`,`mathematical_analysis`.`tests`.`id_yrovni` AS `id_yrovni`,`mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel`,`mathematical_analysis`.`voprosi`.`question_for_difficult_test` AS `question_for_difficult_test` from ((((`mathematical_analysis`.`voprosi_testov` join `mathematical_analysis`.`tests` on((`mathematical_analysis`.`voprosi_testov`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`))) join `mathematical_analysis`.`voprosi` on((`mathematical_analysis`.`voprosi_testov`.`id_vopr` = `mathematical_analysis`.`voprosi`.`id_vopr`))) join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`tests`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`))) join `mathematical_analysis`.`razdel` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`)))