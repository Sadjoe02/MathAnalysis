TYPE=VIEW
query=select `mathematical_analysis`.`voprosi`.`vopros` AS `vopros`,`mathematical_analysis`.`voprosi`.`question_for_difficult_test` AS `question_for_difficult_test`,`mathematical_analysis`.`tests`.`name_test` AS `name_test` from ((`mathematical_analysis`.`voprosi` join `mathematical_analysis`.`voprosi_testov` on((`mathematical_analysis`.`voprosi_testov`.`id_vopr` = `mathematical_analysis`.`voprosi`.`id_vopr`))) join `mathematical_analysis`.`tests` on((`mathematical_analysis`.`voprosi_testov`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`)))
md5=212c560e8ae931e2de28fb645a18b576
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-05-20 14:51:35
create-version=1
source=SELECT
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`voprosi`.`vopros` AS `vopros`,`mathematical_analysis`.`voprosi`.`question_for_difficult_test` AS `question_for_difficult_test`,`mathematical_analysis`.`tests`.`name_test` AS `name_test` from ((`mathematical_analysis`.`voprosi` join `mathematical_analysis`.`voprosi_testov` on((`mathematical_analysis`.`voprosi_testov`.`id_vopr` = `mathematical_analysis`.`voprosi`.`id_vopr`))) join `mathematical_analysis`.`tests` on((`mathematical_analysis`.`voprosi_testov`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`)))