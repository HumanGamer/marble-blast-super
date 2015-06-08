// Task Queue

$tasks = 0;
$ctask = 0;
function addTask(%task)
{
   $taskArray[$tasks] = %task;
   $tasks++;
   if ($ctask == 0)
   {
      nextTask();
   }
}

function nextTask()
{
   if ($ctask >= $tasks)
   {
		$tasks = 0;
		$ctask = 0;
		return;
   }
   eval($taskArray[$ctask]);
   $ctask++;
}
