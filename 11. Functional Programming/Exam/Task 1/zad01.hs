import Data.Char (isDigit)

isNumeric :: String -> Bool
isNumeric str = all isDigit str

main :: IO ()
main = do
  code <- getLine
  if length code /= 4 || not (isNumeric code)
    then putStrLn "Invalid code"
    else
      let [first, second, third, fourth] = code
       in if first == fourth && second == third
            then putStrLn "Unlock"
            else putStrLn "Not unlock"